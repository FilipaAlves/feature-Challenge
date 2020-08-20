using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombChallenge
{
    class Hire
    {
        public enum ColloursList
        {
            branco,
            preto,
            vermelho,
            verde,
            laranja,
            roxo
        }

        public enum RuleWhiteCannotCut
        {
            branco,
            preto
        }

        public enum RuleRedNeedToCute
        {
            verde
        }

        public enum RuleBlackCannotCut
        {
            branco,
            verde,
            laranja
        }

        public enum RuleOrangeNeedToCute
        {
            vermelho,
            preto
        }

        public enum RuleGreenNeedToCute
        {
            laranja,
            branco
        }

        public enum RulePurpleCannotCut
        {
            roxo,
            verde,
            laranja,
            branco
        }
    }
}
