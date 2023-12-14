using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            
            ICommand openCommand = new OpenCommand(document);
            ICommand saveCommand = new SaveCommand(document);
            ICommand closeCommand = new CloseCommand(document);

            MenuOption menuOption = new MenuOption(openCommand, saveCommand, closeCommand); 

            menuOption.clickOpen();
            menuOption.clickSave();
            menuOption.clickClose();
        }
    }
}
