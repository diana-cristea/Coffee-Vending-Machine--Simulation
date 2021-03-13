using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulator
{
    public partial class slider : Component
    {
        public slider()
        {
            InitializeComponent();
        }

        public slider(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
