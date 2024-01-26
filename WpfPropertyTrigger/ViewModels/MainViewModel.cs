using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;
using WpfBase;
using WpfControlTemplate.Models;

namespace WpfControlTemplate.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public MainViewModel()
        {
            Items = ComboItem.Items;
        }

        public List<ComboItem> Items { get; set; }
    }
}
