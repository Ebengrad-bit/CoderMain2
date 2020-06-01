using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CoderMain
{
    public partial class Form1 : Form
    {
        public bool mode;
        int tipe;
        public string normal_text;
        public string coded_text;
        public string key;
        public string fname;
        // size;
        byte[] array;
        int[] array1;
        int Ersa, Nrsa, Drsa;
        int[] ForwardM = new[] {58, 50, 42, 34, 26, 18, 10, 2, 60, 52, 44, 36, 28, 20, 12, 4, 62, 54, 46, 38, 30, 22, 14, 6, 64, 56, 48, 40, 32, 24, 16, 8, 57, 49, 41, 33, 25, 17, 9, 1, 59, 51, 43, 35, 27, 19, 11, 3, 61, 53, 45, 37, 29, 21, 13, 5, 63, 55, 47, 39, 31, 23, 15, 7};
        int[] BackwardM = new[] {40, 8, 48, 16, 56, 24, 64, 32, 39, 7, 47, 15, 55, 23, 63, 31, 38, 6, 46, 14, 54, 22, 62, 30, 37, 5, 45, 13, 53, 21, 61, 29, 36, 4, 44, 12, 52, 20, 60, 28, 35, 3, 43, 11, 51, 19, 59, 27, 34, 2, 42, 10, 50, 18, 58, 26, 33, 1, 41, 9, 49, 17, 57, 25};
        int[,] S =  { {14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7, 0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8, 4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0, 15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13},
                     {15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10, 3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5, 0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15, 13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9},
                     {10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8, 13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1, 13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7, 1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12},
                     {7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15, 13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9, 10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4, 3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14},
                     {2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9, 14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6, 4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14, 11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3},
                     {12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11, 10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8, 9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6, 4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13},
                     {4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1, 13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6, 1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2, 6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12},
                     {13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7, 1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2, 7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8, 2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11}};
        int[] E = {32, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, 16, 17, 16, 17, 18, 19, 20, 21, 20, 21, 22, 23, 24, 25, 24, 25, 26, 27, 28, 29, 28, 29, 30, 31, 32, 01};
        int[] P = {16, 7, 20, 21, 29, 12, 28, 17, 1, 15, 23, 26, 5, 18, 31, 10, 2, 8, 24, 14, 32, 27, 3, 9, 19, 13, 30, 6, 22, 11, 4, 25};
        int[] G = {57, 49, 41, 33, 25, 17, 9, 1, 58, 50, 42, 34, 26, 18, 10, 2, 59, 51, 43, 35, 27, 19, 11, 3, 60, 52, 44, 36, 63, 55, 47, 39, 31, 23, 15, 7, 62, 54, 46, 38, 30, 22, 14, 6, 61, 53, 45, 37, 29, 21, 13, 5, 28, 20, 12, 4};
        int[] H = {14, 17, 11, 24, 1, 5, 3, 28, 15, 6, 21, 10, 23, 19, 12, 4, 26, 8, 16, 7, 27, 20, 13, 2, 41, 52, 31, 37, 47, 55, 30, 40, 51, 45, 33, 48, 44, 49, 39, 56, 34, 53, 46, 42, 50, 36, 29, 32};
        int[] liner = { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mode = true;
            KodingBtn.Checked = true;
            DecodingBtn.Checked = false;
            KeyTextB.Text = GenerateKey(4);
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            tipe = 1;
            //gen = false;
        }

        static private bool Testferma(long x)
        {


            //	BigInteger.ModPow()
            Random rand = new Random();
            if (x == 0)
                return false;
            if (x == 2)
                return true;

            for (int i = 0; i < 100; i++)
            {
                long a = rand.Next((int)x);
                if (a <= 2)
                    a = a + 2;
                if (BigInteger.ModPow(a, x - 1, x) != 1)
                {
                    return false;
                }
            }
            return true;
        }
        private long GCD(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a >= b) a = a % b;
                else b = b % a;
            }
            return a + b; // Одно - ноль
        }
        int Gcd(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0; y = 1;
                return b;
            }
            int x1, y1;
            int d = Gcd(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }
        private void Encode(out int e, out int n, out int d)
        {

            int p, q, w, fi;
            bool c;
            Random rand = new Random();
            do
            {
                p = rand.Next(32000);
                c = Testferma(p);
            }
            while (!c);
            q = p;
            do
            {
                q++;
                c = Testferma(q);
            }
            while (!c);
            n = p * q;
            fi = (p - 1) * (q - 1);
            do
            {
                e = rand.Next(6000);
                Gcd(e, fi, out w, out d);
            }
            while ((GCD(fi, e) != 1) || (w < 0));
            d = w;
        }

        private void KodingBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked==true) mode = true;
            else mode = false;
        }

        private void DecodingBtn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked == true) mode = false;
            else mode = true;
        }
        string GenerateKey(int n)
        {
            string key = "";
            if (tipe == 2) n = 4;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                key += (char)rnd.Next(1024, 1279);

            }

            return key;
        }
        void CodingEasy(string key, string norm, ref string coded)
        {
            coded = "";
            int iter = 0;
            for(int i=0; i<norm.Length;i++)
            {
                if (iter >= key.Length) iter = 0;
                coded += (char)(norm[i] ^ key[iter]);
                iter++;
            }
        }
        void DecodingEasy(string key, ref string norm, string coded)
        {
            norm = "";
            int iter = 0;
            for(int i=0; i<coded.Length;i++)
            {
                if (iter >= key.Length) iter = 0;
                norm += (char)(coded[i] ^ key[iter]);
                iter++;
            }
        }

        string MatrMult(string a, int[] matrix)
        {
            string res = "";
            for(int i=0; i<matrix.Length;i++)
            {
                res += a[matrix[i]-1];
            }
            return res;
        }

        string SMult(string a, int i)
        {
            string res = "";
            int lin = 0;
            int col = 0;
            lin = int.Parse(a[0].ToString()) * 2 + int.Parse(a[5].ToString());
            col = int.Parse(a[1].ToString()) * 8 + int.Parse(a[2].ToString()) * 4 + int.Parse(a[3].ToString()) * 2 + int.Parse(a[4].ToString());
            res = Convert.ToString(S[i,lin*15 + col], 2);
            while (res.Length < 4)
                res = "0"+res;
            return res;
        }

        string StoBin(string input)
        {
            string res = "";
            for(int i=0; i<input.Length;i++)
            {
                string buf = Convert.ToString(input[i], 2);
                while (buf.Length < 16)
                    buf = "0" + buf;
                res += buf;
            }
            return res;
        }

        string XOR(string l, string r)
        {
            string res = "";
            for (int i = 0; i < l.Length; i++)
            {
                bool a = Convert.ToBoolean(Convert.ToInt32(l[i].ToString()));
                bool b = Convert.ToBoolean(Convert.ToInt32(r[i].ToString()));

                if (a ^ b)
                    res += "1";
                else
                    res += "0";
            }
            return res;
        }

        void KeyMaker2(string input, ref string []output)
        {
            input = MatrMult(input, G);
            string c = "", d = "";
            for(int i=0; i<input.Length/2;i++)
            {
                c += input[i];
                d += input[i + 28];
            }
            int nom = 0;
            for(int i=0; i< liner.Length;i++)
            {
                output[i] = "";
                char buf = c[0], bufc=c[0], bufd=d[0];
                nom += liner[i];
                for(int q=0;q<nom;q++)
                {
                    bufc = c[0];
                    bufd = d[0];
                    c = c.Remove(0, 1);
                    d = d.Remove(0, 1);
                    c += bufc;
                    d += bufd;
                }
                output[i] = c + d;
                output[i] = MatrMult(output[i], H);
            }
        }

        string F2(string r, string key_)
        {
            string res = "";

            r = MatrMult(r, E);
            r = XOR(r, key_);
            string buf = "";
            for(int i=0; i<8;i++)
            {
                buf = "";
                for(int j=0; j<6;j++)
                {
                    buf += r[i * 6 + j];
                }
                res += SMult(buf, i);
            }
            res = MatrMult(res, P);
            return res;
        }

        string BtoStr(string a)
        {
            string output = "";

            while (a.Length > 0)
            {
                string char_binary = a.Substring(0, 16);
                a = a.Remove(0, 16);

                int nom = 0;
                int degree = char_binary.Length - 1;

                foreach (char c in char_binary)
                    nom += Convert.ToInt32(c.ToString()) * (int)Math.Pow(2, degree--);

                output += ((char)nom).ToString();
            }

            return output;
        }

        void DesF2(string keym, string norm, ref string coded)
        {
            while (norm.Length % keym.Length != 0)
                norm += "@";
            keym = StoBin(keym);
            string[] keys = new string[16];
            KeyMaker2(keym, ref keys);
            norm = StoBin(norm);
            coded = "";
            for(int i=0;i<norm.Length/keym.Length;i++)
            {
                string buf = "";
                for (int j = 0; j < keym.Length; j++)
                    buf += norm[i * keym.Length + j];
                buf = MatrMult(buf, ForwardM);
                for(int j=0; j<keys.Length;j++)
                {
                    string L = buf.Substring(0, buf.Length / 2);
                    string R = buf.Substring(buf.Length / 2, buf.Length/2);
                    buf = R+XOR(F2(R, keys[j]),L);
                }
                buf = MatrMult(buf,BackwardM);
                coded += buf;
            }
            coded = BtoStr(coded);
        }

        void DesB2(string keym, ref string norm, string coded)
        {
            while (coded.Length % keym.Length != 0)
                coded += "@";
            keym = StoBin(keym);
            string[] keys = new string[16];
            KeyMaker2(keym, ref keys);
            coded = StoBin(coded);
            norm = "";
            for (int i = 0; i < coded.Length / keym.Length; i++)
            {
                string buf = "";
                for (int j = 0; j < keym.Length; j++)
                    buf += coded[i * keym.Length + j];
                buf = MatrMult(buf, ForwardM);
                for (int j = keys.Length-1; j >=0; j--)
                {
                    string L = buf.Substring(0, buf.Length / 2);
                    string R = buf.Substring(buf.Length / 2, buf.Length / 2);
                    buf = XOR(F2(L, keys[j]),R)+L;
                }
                buf = MatrMult(buf, BackwardM);
                norm += buf;
            }
            norm = BtoStr(norm);
        }


        string ID(char[] a, bool mode_)
        {
            string buf="";
            int iter = 0, b = 0, ct = 15;
            char lbuf2;
            lbuf2 = a[0];
            int[] id = new int[64];
            if (mode_)
                id = ForwardM;
            else
                id = BackwardM;
            lbuf2 = (char)0;
            for(int i=0; i<id.Length;i++)
            {
                if(ct<0)
                {
                    ct = 15;
                    buf += lbuf2;
                }
                iter = (id[i]-1) / 16;
                b = 15-(id[i]-1) % 16;
                //lbuf = a[iter];
                if ((a[iter] & (1 << b)) > 0)
                    lbuf2 = (char)(lbuf2 | (1 << ct));
                else
                    lbuf2 = (char)(lbuf2 & ~(1 << ct));
                ct--;
            }
            buf += lbuf2;
            return buf;
        }

        void DesForward(string key, string norm, ref string coded)
        {
            while(norm.Length%key.Length != 0)
            {
                norm += " ";
            }
            coded = "";
            string[] keys = new string[16];
            KeyMakerForward(key, ref keys);
            string bufLR = "", L = "", R_ = "";
            for(int i=0; i<norm.Length/key.Length;i++)
            {
                char[] buf = new char[4];
                for (int j = 0; j < 4; j++)
                    buf[j] = norm[i * 4 + j];
                bufLR = ID(buf, true);
                L = "";
                R_ = "";
                for(int j=0; j<2;j++)
                {
                    L += bufLR[j];
                    R_ += bufLR[2 + j];
                }
                string fbuf = "";
                for(int j=0; j<keys.Length;j++)
                {
                    fbuf = F(R_, keys[j]);
                    bufLR = R_;
                    R_ = "";
                    for (int k = 0; k < L.Length; k++)
                        R_ += (char)(fbuf[k] ^ L[k]);
                    L = bufLR;
                    
                }
                bufLR = L;
                bufLR += R_;
                for (int j = 0; j < 4; j++)
                    buf[j] = bufLR[j];
                bufLR = ID(buf, false);
                coded += bufLR;
            }
        }
        void DesBackward(string key, ref string norm, string coded)
        {
            while (coded.Length % key.Length != 0)
            {
                coded += " ";
            }
            norm = "";
            string[] keys = new string[16];
            KeyMakerForward(key, ref keys);
            string bufLR = "", L = "", R_ = "";
            for (int i = 0; i < coded.Length / key.Length; i++)
            {
                char[] buf = new char[4];
                for (int j = 0; j < 4; j++)
                    buf[j] = coded[i * 4 + j];
                bufLR = ID(buf, false);
                R_ = "";
                L = "";
                for (int j = 0; j < 2; j++)
                {
                    L += bufLR[j];
                    R_ += bufLR[2 + j];
                }
                string fbuf = "";
                for (int j = keys.Length-1; j >=0; j--)
                {
                    fbuf = L;
                    bufLR = R_;
                    R_ = F(L, keys[j]);
                    L = "";
                    for (int k = 0; k < R_.Length; k++)
                        L += (char)(bufLR[k] ^ R_[k]);
                    R_ = fbuf;
                }
                bufLR = L;
                bufLR += R_;
                for (int j = 0; j < 4; j++)
                    buf[j] = bufLR[j];
                bufLR = ID(buf, true);
                norm += bufLR;
            }
        }

        void KeyMakerForward(string keym, ref string[] keys)
        {
            //keys = new string[16];
            string sbuf  = "";
            char buf = keym[0], buf2 = keym[0];
            int iter = 0, b = 0, ct = 15 ;

            /*for(int i=0; i<keym.Length;i++)
            {
                buf = keym[i];
                buf = (char)(buf | (1 << 15));
                sbuf += buf;
            }
            keym = sbuf;
            sbuf = "";
            buf = keym[0];
            buf2 = keym[0];*/

            //*G
            for(int i=0; i<8;i++)
            {
                for(int j=0; j<7;j++)
                {
                    if(ct<0)
                    {
                        ct = 15;
                        sbuf += buf;
                    }
                    iter = (G[i * 7 + j]-1) / 16;
                    b = 15-(G[i * 7 + j]-1) % 16;
                    if ((keym[iter] & (1 << b)) > 0)
                        buf = (char)(buf | (1 << ct));
                    else
                        buf = (char)(buf & ~(1 << ct));
                    ct--;
                }
                sbuf += buf;
            }
            //c d
            //keym = "";
            var c = keys;
            var d = keys;
            int miter = 0;
            
            for(int i=0; i<keys.Length;i++)
            {
                c[i] = "";
                d[i] = "";
                ct = 15;
                miter = 0;
                for (int j=0;j<28;j++)
                {
                    if(ct<0)
                    {
                        ct = 15;
                        c[i] += buf;
                        d[i] += buf2;
                    }
                    iter = (miter) / 16;
                    b = 15-(miter) % 16;
                    if ((keym[iter] & (1 << b)) > 0)
                        buf = (char)(buf | (1 << ct));
                    else
                        buf = (char)(buf & ~(1 << ct));
                    iter = (miter+28) / 16;
                    b = 15-(miter+28) % 16;
                    if ((keym[iter] & (1 << b)) > 0)
                        buf2 = (char)(buf2 | (1 << ct));
                    else
                        buf2 = (char)(buf2 & ~(1 << ct));
                    ct--;
                    miter++;
                }
                c[i] += buf;
                d[i] += buf2;
            }

            //L<<

            int nom = 0;

            for(int q=0; q<2;q++)
            {
                nom = 0;
                for(int i=0; i<liner.Length;i++)
                {
                    if (q > 0) keym = d[i];
                    else keym = c[i];
                    nom += liner[i];

                    for(int k=0; k<nom;k++)
                    {
                        sbuf = "";
                        if ((keym[0] & (1 << 0)) > 0)
                            iter = 1;
                        else
                            iter = 0;
                        //ct = iter;
                        buf = keym[0];
                        buf = (char)(buf >> 1);
                        if ((keym[1] & (1 << 5)) > 0)
                            buf = (char)(buf | (1 << 15));
                        else
                            buf = (char)(buf & ~(1 << 15));
                        sbuf += buf;
                        buf = keym[1];
                        buf = (char)(buf >> 1);
                        if (iter > 0)
                            buf = (char)(buf | (1 << 15));
                        else
                            buf = (char)(buf & ~(1 << 15));
                        sbuf += buf;
                        keym = sbuf;
                    }
                    if (q > 0) d[i] = keym;
                    else c[i] = keym;

                }

            }

            //c+d
            for(int i=0;i<keys.Length;i++)
            {
                keym = "";
                keym += c[i][0];
                miter = 0;
                ct = 5;
                //buf2 = d[i][0];
                buf = c[i][1];
                for(int j=0; j<28;j++)
                {
                    if(ct<0)
                    {
                        keym += buf;
                        ct = 15;
                    }
                    iter = miter / 16;
                    b = 15-miter % 16;
                    //buf=
                    if ((d[i][iter] & (1 << b)) > 0)
                        buf = (char)(buf | (1 << ct));
                    else
                        buf = (char)(buf & ~(1 << ct));
                    ct--;
                    miter++;
                }
                keym += buf;
                keys[i] = keym;
            }

            //*H
            for (int i = 0; i < keys.Length; i++)
            {
                keym = "";
                ct = 15;
                sbuf = keys[i];
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if (ct <0)
                        {
                            ct = 15;
                            keym += buf;
                        }
                        iter = (H[j * 6 + k] - 1) / 16;
                        b = 15-(H[j * 6 + k] - 1) % 16;
                        if ((sbuf[iter] & (1 << b)) > 0)
                            buf = (char)(buf | (1 << ct));
                        else
                            buf = (char)(buf & ~(1 << ct));
                        ct--;
                    }

                }
                keym += buf;
                keys[i] = keym;
            }
        }

        string F(string R, string key_)
        {
            string buf = "";
            int iter = 0, b = 0, ct = 15;
            char lbuf, lbuf2;
            lbuf2 = R[0];
            lbuf = R[0];
            //*E
            for (int i = 0; i < E.Length; i++)
            {
                if(ct<0)
                {
                    ct = 15;
                    buf += lbuf2;
                }
                iter = (E[i]-1) / 16;
                b = 15-(E[i]-1) % 16;
                lbuf = R[iter];
                if ((lbuf & (1 << b)) > 0)
                    lbuf2 = (char)(lbuf2 | (1 << ct));
                else
                    lbuf2 = (char)(lbuf2 & ~(1 <<  ct));
                ct--;
            }
            buf += lbuf2;

            R = "";
            //xor key
            for (int i = 0; i < 3; i++)
                R += (char)(buf[i] ^ key_[i]);

            //*S

            ct = 15;
            int sbuf = 0, linebuf = 0, combuf = 0;
            buf = "";
            for(int i=0; i<8; i++)
            {
                iter = (i * 6+5) / 16;
                b = 15-(i * 6+5) % 16;
                linebuf = 0;
                if ((R[iter] & (1 << b)) > 0)
                    linebuf++;
                linebuf *= 2;
                iter = (i * 6) / 16;
                b = 15-(i * 6) % 16;
                if ((R[iter] & (1 << b)) > 0)
                    linebuf++;
                combuf = 0;
                for(int j=1;j<5;j++)
                {
                    iter = (i * 6 + j) / 16;
                    b = 15-(i * 6 + j) % 16;
                    if ((R[iter] & (1 << b)) > 0)
                        combuf = (char)(combuf | (1 << (j-1)));
                    else
                        combuf = (char)(combuf & ~(1 << (j-1)));
                }
                sbuf = S[i, linebuf * 16 + combuf];
                for(int j=0; j<4;j++)
                {
                    if (ct <0)
                    {
                        ct = 15;
                        buf += lbuf;
                    }
                    if((sbuf & (1<<j))>0)
                        lbuf = (char)(lbuf | (1 << ct));
                    else
                        lbuf = (char)(lbuf & ~(1 << ct));
                    ct--;
                }
                buf += lbuf;
            }

            //*p
            ct = 15;
            R = "";
            for(int i = 0; i<P.Length;i++)
            {
                if(ct<0)
                {
                    ct = 15;
                    R += lbuf;
                }
                iter = (P[i]-1) / 16;
                b = 15-(P[i]-1) % 16;
                if((buf[iter] & (1<<b))>0)
                    lbuf = (char)(lbuf | (1 << ct));
                else
                    lbuf = (char)(lbuf & ~(1 << ct));
                ct--;
            }
            R += lbuf;

            return R;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (mode)
            {
                if (NormalTextB.TextLength == 0) return;
                key = KeyTextB.Text;
                normal_text = NormalTextB.Text;
                switch (tipe)
                {
                    case 1:
                        CodingEasy(key, normal_text, ref coded_text); break;
                    case 2:
                        DesF2(key, normal_text, ref coded_text); break;
                    case 3:
                        {
                            array = Encoding.GetEncoding(1251).GetBytes(normal_text);

                            array1 = new int[array.Length];

                            Encode(out Ersa, out Nrsa, out Drsa);
                            OpendCodeText.Text = Convert.ToString(Ersa);
                            ClosedCodeText.Text = Convert.ToString(Drsa);
                            coded_text = "";
                            for (int i = 0; i < array.Length; i++)
                            {
                                array1[i] = (int)BigInteger.ModPow(array[i], Ersa, Nrsa);
                                coded_text += Convert.ToString(array1[i]);
                                coded_text += " ";
                            }
                            break;
                        }
                }
                CodedTextB.Text = coded_text;
            }
            else
            {
                if (CodedTextB.TextLength == 0) return;
                key = KeyTextB.Text;
                coded_text = CodedTextB.Text;
                switch(tipe)
                {
                    case 1:
                        DecodingEasy(key, ref normal_text, coded_text);break;
                    case 2:
                        DesB2(key, ref normal_text, coded_text); break;
                    case 3:
                        {
                            OpendCodeText.Text = Convert.ToString(Ersa);
                            ClosedCodeText.Text = Convert.ToString(Drsa);
                            normal_text = "";
                            for (int i = 0; i < array.Length; i++)
                            {
                                array[i] = (byte)BigInteger.ModPow(array1[i], Drsa, Nrsa);
                            }

                            normal_text = Encoding.GetEncoding(1251).GetString(array);
                            break;
                        }
                }
                NormalTextB.Text = normal_text;
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            fname = dlg.FileName;
            string buf = System.IO.File.ReadAllText(fname, Encoding.GetEncoding(1251));
            if (mode) NormalTextB.Text = buf;
            else CodedTextB.Text = buf;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            dlg.CreatePrompt = true;
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            fname = dlg.FileName;
            System.IO.File.WriteAllText(fname, coded_text, Encoding.GetEncoding(1251));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked == true) tipe = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked == true) tipe = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked == true)
            {
                tipe = 3;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
