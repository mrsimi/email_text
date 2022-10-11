using System;
using System.Text;
using System.Xml;

namespace email_test
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    class Class1
    {
        static void Main(string[] args)
        {
            String URLString = "data.xml";
            XmlTextReader reader = new XmlTextReader (URLString);
            
            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        if (reader.Name != "see" && reader.Name != "c" && reader.Name != "paramref")
                        {
                            var title = (" " + reader.Name + "=>");
                            sb.Append(title);
                            

                            while (reader.MoveToNextAttribute()) // Read the attributes.
                                sb.Append(reader.Name + "='" + reader.Value+"'");

                        }
                        //Console.Write(">");
                        //Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        sb.Append(reader.Value.Trim());
                        break;
                    // case XmlNodeType. EndElement: //Display the end of the element.
                    //     Console.Write("</" + reader.Name);
                    //     Console.Write("> \n");
                    //     break;
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}