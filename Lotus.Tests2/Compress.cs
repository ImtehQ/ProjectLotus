using Lotus.Compression;
using System;
using Xunit;

namespace Lotus.Tests2
{
    public class Compress
    {
        [Fact]
        public void Compression_Patch_NOTNULL()
        {
            Compression.Compress c = new Compression.Compress(new Paths());
            
            Assert.Null(c.CheckPath());

        }
    }
}
