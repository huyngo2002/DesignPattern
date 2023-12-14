using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public class CloseCommand : ICommand
    {
        private Document _document;

        public CloseCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Close();
        }
    }
}
