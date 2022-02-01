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
            {'A',new int[5]{2, 5, 4, 3, 1 } },
            {'B',new int[5]{5, 2, 4, 3, 1 } },
            {'C',new int[5]{5, 2, 3, 4, 1 } },
            {'D',new int[5]{4, 1, 2, 3, 5 } },
            {'E',new int[5]{1, 4, 2, 5, 3 } },
            {'F',new int[5]{5, 1, 3, 4, 2 } },
            {'G',new int[5]{5, 1, 3, 4, 2 } },
            {'H',new int[5]{4, 5, 1, 2, 3 } },
            {'I',new int[5]{1, 5, 4, 3, 2 } },
            {'J',new int[5]{5, 1, 4, 3, 2 } },
            {'K',new int[5]{4, 1, 3, 5, 2 } },
            {'L',new int[5]{2, 3, 5, 4, 1 } },
            {'M',new int[5]{5, 2, 4, 3, 1 } },
            {'N',new int[5]{1, 2, 5, 4, 3 } },
            {'O',new int[5]{1, 5, 4, 3, 2 } },
            {'P',new int[5]{5, 2, 3, 4, 1 } },
            {'Q',new int[5]{5, 4, 3, 1, 2 } },
            {'R',new int[5]{1, 4, 5, 3, 2 } },
            {'S',new int[5]{4, 1, 3, 2, 5 } },
            {'T',new int[5]{4, 1, 2, 5, 3 } },
            {'U',new int[5]{2, 5, 4, 3, 1 } },
            {'V',new int[5]{5, 2, 4, 3, 1 } },
            {'W',new int[5]{5, 3, 4, 2, 1 } },
            {'X',new int[5]{2, 3, 5, 1, 4 } },
            {'Y',new int[5]{4, 3, 2, 1, 5 } },
            {'Z',new int[5]{3, 1, 5, 4, 2 } }
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
