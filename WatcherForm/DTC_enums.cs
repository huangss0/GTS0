using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTCC
{
    enum FTPserverType
    {
        Production,
        Testing,
    }

    enum FTPrequestType
    {
        Input,
        Output,
    }

    enum DTCfunction
    {
        APIBAL,
        ATODTC,
        OSOLPR,
    }

    enum FTPheaderType
    {
        HDR, //default
        NON, //No Header or Trailer
    }

    enum GroupUserSelCirteria
    {
        ALL,
        Single,
    }
}
