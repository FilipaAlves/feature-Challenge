using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombChallenge
{
    public class Bomb
    {
        public static void BombOutput(string input)
        {
            BombOutputVM bombOutput = ProcessBombDisarm(input);

            switch (bombOutput.BombState)
            {
                case (int)BombStates.expload:
                    Output(ConsoleColor.Red, ConsoleColor.White, "Bomba explodiu!", true);
                    break;

                case (int)BombStates.anotherHire:
                    Output(ConsoleColor.Yellow, ConsoleColor.Black, "Cortar outro fio!", false);
                    string newInput = Console.ReadLine();
                    newInput = $"{bombOutput.LastPosition}, {newInput}";

                    BombOutput(newInput);
                    break;

                case (int)BombStates.error:
                    Output(ConsoleColor.Red, ConsoleColor.White, $"ERRO, O fio que cortou '{bombOutput.IncorretInput}', não corresponde a uma das cores esperadas.\nEscolha entre as cores disponíveis:\nbranco, preto, vermelho, verde, laranja, roxo.\nTenha atenção que cada cor que colocar tem que estar dividida por virgulas!", true);
                    break;

                default:
                    Output(ConsoleColor.Green, ConsoleColor.White, "Bomba Desarmada!", true);
                    break;
            }

        }
        public static BombOutputVM ProcessBombDisarm(string input)
        {
            string[] inputs = input.ToLower().Split(',');

            BombStates bombState = BombStates.sucess;
            int beforeLastPosition = inputs.Length - 2;
            int lastPosition = inputs.Length - 1;

            for (int i = 0; i < inputs.Length; i++)
            {
                string currentVal = inputs[i].Trim();
                if (Enum.IsDefined(typeof(Hire.ColloursList), currentVal))
                {
                    if (bombState != BombStates.expload)
                    {
                        if (i <= beforeLastPosition)
                        {
                            string nextVal = inputs[i + 1].Trim();

                            switch (currentVal)
                            {
                                case "branco":

                                    if (Enum.IsDefined(typeof(Hire.RuleWhiteCannotCut), nextVal))
                                    {
                                        bombState = BombStates.expload;
                                        break;
                                    }
                                    else continue;

                                case "vermelho":
                                    if (!Enum.IsDefined(typeof(Hire.RuleRedNeedToCute), nextVal))
                                    {
                                        bombState = BombStates.expload;
                                        break;
                                    }
                                    else continue;

                                case "preto":
                                    if (Enum.IsDefined(typeof(Hire.RuleBlackCannotCut), nextVal))
                                    {
                                        bombState = BombStates.expload;
                                        break;
                                    }
                                    else continue;

                                case "laranja":
                                    if (!Enum.IsDefined(typeof(Hire.RuleOrangeNeedToCute), nextVal))
                                    {
                                        bombState = BombStates.expload;
                                        break;
                                    }
                                    else continue;

                                case "verde":
                                    if (!Enum.IsDefined(typeof(Hire.RuleGreenNeedToCute), nextVal))
                                    {
                                        bombState = BombStates.expload;
                                        break;
                                    }
                                    else continue;

                                case "roxo":
                                    if (Enum.IsDefined(typeof(Hire.RulePurpleCannotCut), nextVal))
                                    {
                                        bombState = BombStates.expload;
                                        break;
                                    }
                                    else continue;
                            }
                        }
                        if (i == lastPosition && (currentVal.Contains(Hire.ColloursList.verde.ToString()) || currentVal.Contains(Hire.ColloursList.laranja.ToString()) || currentVal.Contains(Hire.ColloursList.vermelho.ToString())))
                        {
                            bombState = BombStates.anotherHire;
                        }
                    }
                }
                else
                {
                    return new BombOutputVM { BombState = 3, IncorretInput = currentVal };
                }

            }
            return new BombOutputVM { BombState = (int)bombState, IncorretInput = null, LastPosition = inputs[lastPosition].Trim() };
        }
        public static void Output(ConsoleColor backgroundCollour, ConsoleColor foregroundColor, string text, bool closeApp)
        {

            Console.BackgroundColor = backgroundCollour;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(text);
            Console.ResetColor();
            if (closeApp)
            {
                Console.WriteLine("Pressione Enter para fechar...");
                Console.ReadLine();
            }
        }
    }
}
