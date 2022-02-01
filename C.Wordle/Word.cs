using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Wordle
{
    public class Word
    {
        private Boolean flagged;
        private string mot;
        private long score;

        public Boolean Flagged {
            get { return flagged; }
            set { flagged = value; }
        }
        public string Mot {
            get { return mot; }
        }
        public long Score {
            get { return score; }
        }

        Dictionary<char, int> freqs = new Dictionary<char, int>()
        {
            {'S', 6665},
            {'E', 6662},
            {'A', 5990},
            {'O', 4438},
            {'R', 4158},
            {'I', 3759},
            {'L', 3371},
            {'T', 3295},
            {'N', 2952},
            {'U', 2511},
            {'D', 2453},
            {'Y', 2074},
            {'C', 2028},
            {'P', 2019},
            {'M', 1976},
            {'H', 1760},
            {'G', 1644},
            {'B', 1627},
            {'K', 1505},
            {'F', 1115},
            {'W', 1039},
            {'V', 694 },
            {'Z', 434 },
            {'J', 291 },
            {'X', 288 },
            {'Q', 112 }
        };

        Dictionary<char, int[]> pos = new Dictionary<char, int[]>()
        {
            {'A',new int[5]{ 737, 2263, 1236, 1074, 680 } },
            {'B',new int[5]{909, 81, 335, 243, 59 } },
            {'C',new int[5]{922, 176, 392, 411, 127 } },
            {'D',new int[5]{685, 84, 390, 471, 823 } },
            {'E',new int[5]{303, 1628, 882, 2327, 1522 } },
            {'F',new int[5]{598, 24, 178, 233, 82 } },
            {'G',new int[5]{638, 76, 364, 423, 143 } },
            {'H',new int[5]{489, 546, 120, 235, 370 } },
            {'I',new int[5]{165, 1383, 1051, 880, 280 } },
            {'J',new int[5]{202, 11, 46, 29, 3 } },
            {'K',new int[5]{376, 95, 272, 503, 259 } },
            {'L',new int[5]{577, 699, 848, 771, 476 } },
            {'M',new int[5]{693, 188, 511, 402, 182 } },
            {'N',new int[5]{325, 345, 964, 788, 530 } },
            {'O',new int[5]{262, 2096, 993, 698, 389 } },
            {'P',new int[5]{859, 231, 364, 418, 147 } },
            {'Q',new int[5]{78 , 15, 13, 2, 4 } },
            {'R',new int[5]{628, 940, 1198, 719, 673 } },
            {'S',new int[5]{1565, 93,  533, 516, 3958 } },
            {'T',new int[5]{815, 239, 616, 898, 727 } },
            {'U',new int[5]{189, 1187, 667, 401, 67 } },
            {'V',new int[5]{242, 52, 240, 156, 4}},
            {'W',new int[5]{413, 163, 271, 128, 64} },
            {'X',new int[5]{16, 57,  133, 12,  70} },
            {'Y',new int[5]{181, 271, 213, 108, 1301} },
            {'Z',new int[5]{105, 29, 142, 126, 32} }
        };      

        public Word(string w)
        {
            flagged = false;
            mot = w.ToUpper();

            string t = "";
            for(int i=0; i<5; i++)
            {
                char c = mot.Substring(i, 1).ToCharArray()[0];
                if (t.IndexOf(c) < 0)
                {
                    score += freqs[c] + pos[c][i];
                    t += c;
                }
            }
        }

        public Word()
        {
            flagged = false;
            mot = "";
            score = 0;
        }
    }
}
