﻿using SistemasConsultas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.BSS
{
    public class ProductoVendidoTipoProdBSS
    {
        ProdVendidosPorTipoProdDAL dal = new ProdVendidosPorTipoProdDAL();
        public DataTable ProductosTipoProdBss()
        {
            return dal.ListarProductosVendidosTipoProdDal();
        }
    }
}
