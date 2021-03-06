﻿using System.Collections.Generic;

namespace SRPCleanMvcWinForms
{
    public interface IProductView
    {
        void Initialize(IProductPresenter presenter);

        string ShowOpenXmlFileDialog();

        string GetSourceIndicator();

        void SetFileName(string fileName);

        void ShowProducts(IEnumerable<Product> products);
    }
}
