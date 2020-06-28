using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class MODELOCandidato
    {
        int IDPESSOA;
        int IDELEICAO;
        int IDEMPRESA;
        int NUMERO;
        string SLOGAN;
        string DESCRICAO;
        byte[] FOTO;

        public int IDPESSOA1 { get => IDPESSOA; set => IDPESSOA = value; }
        public int IDELEICAO1 { get => IDELEICAO; set => IDELEICAO = value; }
        public int IDEMPRESA1 { get => IDEMPRESA; set => IDEMPRESA = value; }
        public int NUMERO1 { get => NUMERO; set => NUMERO = value; }
        public string SLOGAN1 { get => SLOGAN; set => SLOGAN = value; }
        public string DESCRICAO1 { get => DESCRICAO; set => DESCRICAO = value; }
        public byte[] FOTO1 { get => FOTO; set => FOTO = value; }

        public void carregarImagem(String imgc)
        {
            try
            {
                if (string.IsNullOrEmpty(imgc))
                {
                    return;
                }
                FileInfo arqimg = new FileInfo(imgc);
                FileStream fs = new FileStream(imgc, FileMode.Open, FileAccess.Read, FileShare.Read);
                FOTO1 = new byte[Convert.ToInt32(arqimg.Length)];
                int IBytes = fs.Read(FOTO1, 0, Convert.ToInt32(arqimg.Length));
                fs.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public Bitmap getImagem()
        {
            MemoryStream mStream = new MemoryStream();
            mStream.Write(FOTO1, 0, Convert.ToInt32(FOTO1.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }

}
