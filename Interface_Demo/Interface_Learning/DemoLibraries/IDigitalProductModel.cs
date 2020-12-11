using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibraries
{
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get; }
    }
}
