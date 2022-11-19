using System;
namespace Variable_name_generator
{
    /// <summary>
    /// Class for processing variable name (generate or translate)
    /// </summary>
    public class Name_processing
    {
        //*******************************************************************************
        // Variables

        public string optionsLine { get; private set; } = "";

        public List<string> infoScreen { get; private set; }

        /// <summary>
        /// Inicialize name proccesor with default settings and start screen
        /// </summary>
        public Name_processing()
        {
            infoScreen = new List<string>();
            createStartScreen();
        }

        /// <summary>
        /// Write full fill border line "***...***"
        /// </summary>
        public void createStartScreen()
        {
            infoScreen.Clear();
            infoScreen.Add("Welcome to startup screen");
            infoScreen.Add("");
            infoScreen.Add("Choose translate or generate unique variable name");

            optionsLine = "[T]ranslate-[G]enerate-[E]xit";
        }

        /// <summary>
        /// Write full fill border line "***...***"
        /// </summary>
        public void createTranslateScreen()
        {
            infoScreen.Clear();
            infoScreen.Add("Translator");
            infoScreen.Add("");
            infoScreen.Add("Write your variable name to translate or cancel");

            optionsLine = "[C]ancel";
        }
    }
}

