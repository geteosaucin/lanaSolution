using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace lana.DTO
{
    public class ProdutoDTO
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public string UrlImgProduto { get; set; }
        public int EstoqueProduto { get; set; }
        public bool EmLancamento { get; set; }
        public double PrecoProduto { get; set; }
        public string CategoriaId { get; set; }

        [NotMapped]
        public Bitmap Picture
        {
            get
            {
                if (!string.IsNullOrEmpty(UrlImgProduto))
                {
                    if (File.Exists(UrlImgProduto))
                   
                        return (Bitmap)Bitmap.FromFile(UrlImgProduto);
                    
                }
                return null;

            }

        }
    }
}
