using System;
using System.IO;
using System.Text;

namespace TMNT_Tello
{
    /// <summary>
    /// This class is very heavily based on xnbcli by LeonBlade at https://github.com/LeonBlade/xnbcli
    /// </summary>
    class Xnb
    {
        const byte HIDEF_MASK = 0x1;
        const byte COMPRESSED_LZ4_MASK = 0x40;
        const byte COMPRESSED_LZX_MASK = 0x80;

        XnbHeader _header;
        XnbContent _content;
        BinaryReader _buffer = null;

        public XnbHeader Header
        {
            get => _header;
            set => _header = value;
        }
        public XnbContent Content
        {
            get => _content;
            set => _content = value;
        }
        public BinaryReader Buffer
        {
            get => _buffer;
            set => _buffer = value;
        }
        public int FileSize { get; set; } = 0;

        public void Load(Stream input)
        {
            // credits to LeonBlade and xnbcli for the logic here
            XnbContent _content = new();

            _buffer = new BinaryReader(input, Encoding.Unicode);

            // includes readers which also advance the current position of the stream
            ValidateHeader();

            FileSize = _buffer.ReadInt32();

            // unused but needed to advance to the next bytes
            int readerCount = Read7BitNumber();
            int dataLength = Read7BitNumber();
            byte[] bytesRead = _buffer.ReadBytes(dataLength);   // byte array of Reader Type
            int readerVersion = _buffer.ReadInt32();
            int sevenBitValueOfSharedResource = Read7BitNumber();
            int readerIndex = Read7BitNumber() - 1;

            // finally, read the buffer
            _content.Read(_buffer);

            Content = _content;
        }

        public void ValidateHeader()
        {
            // credits to LeonBlade and xnbcli for the logic here
            XnbHeader _header = new();
            byte[] bytes = _buffer.ReadBytes(3);
            string thisShouldBeXNB = Encoding.Default.GetString(bytes);
            if (thisShouldBeXNB != "XNB")
                throw new Exception("This is not an XNB file!");

            /*****
             * TARGET
             * w = Windows
             * m = Windows Phone
             * x = Xbox 360
             * a = Android
             * i = iOS
             */
            /*****
             * FORMAT VERSION
             * 0x3 = XNB Format Version: XNA Game Studio 3.0
             * 0x4 = XNB Format Version: XNA Game Studio 3.1
             * 0x5 = XNB Format Version: XNA Game Studio 4.0
             */
            bytes = _buffer.ReadBytes(1);
            _header.Target = Encoding.Default.GetString(bytes).ToLower();
            _header.FormatVersion = _buffer.ReadByte();
            int flags = _buffer.ReadByte();
            _header.HiDef = (flags & HIDEF_MASK) != 0;
            _header.Compressed = ((flags & COMPRESSED_LZX_MASK) != 0) || ((flags & COMPRESSED_LZ4_MASK) != 0);
        }

        private int Read7BitNumber()
        {
            // credits to LeonBlade and xnbcli for this function
            int readResult = 0;
            int bitsRead = 0;
            int value;
            do
            {
                value = _buffer.ReadByte();
                readResult |= (value & 0x7F) << bitsRead;
                bitsRead += 7;
            }
            while ((value & 0x80) != 0);
            return readResult;
        }
    }

    class XnbHeader
    {
        // credits to LeonBlade and xnbcli for the logic here
        string _target = "";
        int _formatVersion = 0;
        bool _hiDef = false;
        bool _compressed = false;
        public string Target
        {
            get => _target;
            set => _target = value;
        }
        public int FormatVersion
        {
            get => _formatVersion;
            set => _formatVersion = value;
        }
        public bool HiDef
        {
            get => _hiDef;
            set => _hiDef = value;
        }
        public bool Compressed
        {
            get => _compressed;
            set => _compressed = value;
        }
    }

    class XnbContent
    {
        // credits to LeonBlade and xnbcli for the logic here
        XnbContentExport _export;

        public void Read(BinaryReader _buffer)
        {
            int format = _buffer.ReadInt32();   // unused but needed to advance to the next bytes
            int width = (int)_buffer.ReadUInt32();
            int height = (int)_buffer.ReadUInt32();
            int mipCount = (int)_buffer.ReadUInt32();   // unused but needed to advance to the next bytes

            int dataSize = (int)_buffer.ReadUInt32();
            byte[] data = _buffer.ReadBytes(dataSize);

            XnbContentExport _export = new();
            _export.Data = data;
            _export.Width = width;
            _export.Height = height;
            Export = _export;
        }

        public XnbContentExport Export
        {
            get => _export;
            set => _export = value;
        }
    }

    public class XnbContentExport
    {
        // credits to LeonBlade and xnbcli for the logic here
        public byte[] Data { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public void PrepareExport()
        {
            byte[] data = Data;
            byte[] newData = new byte[data.Length];

            try
            {
                // flip the original data's BGRA format into RGBA
                int offset = 0;
                for (int y = 0; y < Height; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        newData[offset] = data[offset + 2];
                        newData[offset + 1] = data[offset + 1];
                        newData[offset + 2] = data[offset];
                        newData[offset + 3] = data[offset + 3];

                        offset += 4;
                    }
                }

                Data = newData;
            }
            catch
            {
                Data = null;
            }

        }
    }
}
