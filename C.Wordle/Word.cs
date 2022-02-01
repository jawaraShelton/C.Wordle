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
            get { return flagged;  } 
            set { flagged = value;  } 
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
                    score += freqs[c];
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
