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
        private float score;

        public Boolean Flagged {
            get { return flagged; }
            set { flagged = value; }
        }
        public string Mot {
            get { return mot; }
        }
        public float Score {
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

        Dictionary<char, float[]> pos = new Dictionary<char, float[]>()
        {
            {'S', new float[5]{0.1206F, 0.0072F, 0.0411F, 0.0398F, 0.3051F } },
			{'E', new float[5]{0.0234F, 0.1255F, 0.0680F, 0.1794F, 0.1173F } },
			{'Y', new float[5]{0.0140F, 0.0209F, 0.0164F, 0.0083F, 0.1003F } },
			{'D', new float[5]{0.0528F, 0.0065F, 0.0301F, 0.0363F, 0.0634F } },
			{'T', new float[5]{0.0628F, 0.0184F, 0.0475F, 0.0692F, 0.0560F } },
			{'A', new float[5]{0.0568F, 0.1745F, 0.0953F, 0.0828F, 0.0524F } },
			{'R', new float[5]{0.0484F, 0.0725F, 0.0924F, 0.0554F, 0.0519F } },
			{'N', new float[5]{0.0251F, 0.0266F, 0.0743F, 0.0607F, 0.0409F } },
			{'L', new float[5]{0.0445F, 0.0539F, 0.0654F, 0.0594F, 0.0367F } },
			{'O', new float[5]{0.0202F, 0.1616F, 0.0765F, 0.0538F, 0.0300F } },
			{'H', new float[5]{0.0377F, 0.0421F, 0.0093F, 0.0181F, 0.0285F } },
			{'I', new float[5]{0.0127F, 0.1066F, 0.0810F, 0.0678F, 0.0216F } },
			{'K', new float[5]{0.0290F, 0.0073F, 0.0210F, 0.0388F, 0.0200F } },
			{'M', new float[5]{0.0534F, 0.0145F, 0.0394F, 0.0310F, 0.0140F } },
			{'P', new float[5]{0.0662F, 0.0178F, 0.0281F, 0.0322F, 0.0113F } },
			{'G', new float[5]{0.0492F, 0.0059F, 0.0281F, 0.0326F, 0.0110F } },
			{'C', new float[5]{0.0711F, 0.0136F, 0.0302F, 0.0317F, 0.0098F } },
			{'F', new float[5]{0.0461F, 0.0019F, 0.0137F, 0.0180F, 0.0063F } },
			{'X', new float[5]{0.0012F, 0.0044F, 0.0103F, 0.0009F, 0.0054F } },
			{'U', new float[5]{0.0146F, 0.0915F, 0.0514F, 0.0309F, 0.0052F } },
			{'W', new float[5]{0.0318F, 0.0126F, 0.0209F, 0.0099F, 0.0049F } },
			{'B', new float[5]{0.0701F, 0.0062F, 0.0258F, 0.0187F, 0.0045F } },
			{'Z', new float[5]{0.0081F, 0.0022F, 0.0109F, 0.0097F, 0.0025F } },
			{'V', new float[5]{0.0187F, 0.0040F, 0.0185F, 0.0120F, 0.0003F } },
			{'Q', new float[5]{0.0060F, 0.0012F, 0.0010F, 0.0002F, 0.0003F } },
			{'J', new float[5]{0.0156F, 0.0008F, 0.0035F, 0.0022F, 0.0002F } }
        };      

        public Word(string w)
        {
            flagged = false;
            mot = w.ToUpper();

            string t = "";
            for(int i=0; i<5; i++)
            {
                char c = mot.Substring(i, 1).ToCharArray()[0];
                score += pos[c][i] + (t.IndexOf(c) < 0 ? freqs[c] : 0);
                t += c;
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
