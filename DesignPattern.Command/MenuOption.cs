using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public class MenuOption
    {
        private ICommand openCommand;
        private ICommand saveCommand;
        private ICommand closeCommand;

        public MenuOption(ICommand openCommand, ICommand saveCommand, ICommand closeCommand)
        {
            this.openCommand = openCommand;
            this.saveCommand = saveCommand;
            this.closeCommand = closeCommand;
        }

        public void clickOpen()
        {
            openCommand.Execute();
        }
        public void clickSave()
        {
            saveCommand.Execute();
        }
        public void clickClose()
        {
            closeCommand.Execute();
        }
    }
}
