using System;
namespace Variable_name_generator
{
    /// <summary>
    /// Class for console screen rendering
    /// </summary>
    public class Screen_rendering
    {
        /// <summary>
        /// Applications name
        /// </summary>
        private string appName = "";

        /// <summary>
        /// Screen width in number of characters
        /// </summary>
        private int screenWidth = 20;

        /// <summary>
        /// Character used for rendering borders
        /// </summary>
        private char borderChar = '*';

        /// <summary>
        /// Space between borders and screen content
        /// </summary>
        private int borderSpacing = 4;

        /// <summary>
        /// Inicialize renderer with DEFAULT settings and WITHOUT app name
        /// </summary>
        public Screen_rendering()
        {

        }

        /// <summary>
        /// Inicialize renderer with custom window size and WITHOUT app name
        /// </summary>
        public Screen_rendering(int _screenWidth)
        {
            if (_screenWidth > screenWidth)
                this.screenWidth = _screenWidth;
        }

        /// <summary>
        /// Inicialize renderer with custom window size and app name
        /// </summary>
        /// <param name="_screenWidth">Screen width</param>
        /// <param name="_appName">Application name</param>
        public Screen_rendering(int _screenWidth, string _appName)
        {
            this.appName = _appName;
            if (_screenWidth > screenWidth)
                this.screenWidth = _screenWidth;
            if (_appName.Length >= (this.screenWidth - (2 * borderSpacing)))
                this.appName = _appName.Remove(this.screenWidth - (2 * this.borderSpacing));
            else
                this.appName = _appName;
        }

        /// <summary>
        /// Write full fill border line "***...***"
        /// </summary>
        public void Write_border_line()
        {
            for (int i = 1; i <= screenWidth; i++)
            {
                Console.Write(borderChar);
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Write line with empty space between borders "*  ...  *"
        /// </summary>
        public void Write_empty_line()
        {
            for (int i = 1; i <= screenWidth; i++)
            {
                if (i == 1 || i == screenWidth)
                    Console.Write(borderChar);
                else
                    Console.Write(' ');

            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Format any string for use in window
        /// </summary>
        /// <param name="_outputText">Text formating for use in output line</param>
        public string Format_text_line(string _outputText)
        {
            string textLine = "";

            
            textLine += borderChar;

            for (int i = 1; i < borderSpacing; i++)
            {
                textLine += " ";
            }

            if (_outputText.Length + textLine.Length <= screenWidth - borderSpacing)
                textLine += _outputText;
            else
                textLine += "Adjust win width";


            for (int i = textLine.Length + 1; i <= screenWidth; i++)
            {
                if (i == screenWidth)
                    textLine += borderChar;
                else
                    textLine += " ";
            }
            return textLine;
        }

        /// <summary>
        /// Format line with possible feedback options
        /// </summary>
        /// <param name="_outputText">Write preformated text with feedback options</param>
        public string Format_feedback_line(string _outputText)
        {
            _outputText = Format_text_line(_outputText);
            return _outputText.Replace(' ', borderChar);
        }

        /// <summary>
        /// Write line from preformated string
        /// </summary>
        /// <param name="_outputText">Write preformated general output line</param>
        public void Write_preformated_line(string _outputText)
        {
            Console.WriteLine(_outputText);
        }

        /// <summary>
        /// Write line from preformated string
        /// </summary>
        /// <param name="_outputTextLines">Write multiple preformated general output line</param>
        public void Write_multiple_options_line(string[] _outputTextLines)
        {
            foreach (var textLine in _outputTextLines)
            {
                Write_preformated_line(Format_text_line(textLine));
            }
        }

        /// <summary>
        /// Write console input line
        /// </summary>
        public void Render_question_screen(string[] _outputTextLines)
        {
            
        }

        /// <summary>
        /// Render question window with options and 
        /// </summary>
        public void Write_input_line()
        {
            Console.Write("Input << ");
        }

        public override string ToString()
        {
            string outputString = "Renderer : Window width : " + screenWidth + " , app name : ";

            if (appName != "")
                outputString += appName;
            else
                outputString += "Null";

            return outputString;
        }
    }
}

