using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public class OpenCommand : ICommand
    {
        private Document _document;

        public OpenCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Open();
        }
    }
}
