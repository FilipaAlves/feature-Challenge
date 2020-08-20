using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombChallenge
{
    public class BombOutputVM
    {
        public int BombState { get; set; }
        public string IncorretInput { get; set; }
        public string LastPosition { get; set; }
    }

    public enum BombStates
    {
        sucess,
        expload,
        anotherHire,
        error
    }
}
