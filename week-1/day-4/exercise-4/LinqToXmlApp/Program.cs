using System.Xml.Linq;

namespace LinqToXmlApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assume there is an XML document with the following structure:
            // <Books>
            //     <Book>
            //         <Title>Book Title 1</Title>
            //         <Author>Author 1</Author>
            //         <Genre>Genre 1</Genre>
            //     </Book>
            //     ...
            // </Books>
            // Write above book structure as a c# string
            string xmlString = @"<Books>
                                    <Book>
                                        <Title>Can't Hurt Me</Title>
                                        <Author>David Goggins</Author>
                                        <Genre>Biography</Genre>
                                    </Book>
                                    <Book>
                                        <Title>The Psychology Of Money</Title>
                                        <Author>Morgan Housel</Author>
                                        <Genre>Study Guide</Genre>
                                    </Book>
                                    <Book>
                                        <Title>Atomic Habits</Title>
                                        <Author>James Clear</Author>
                                        <Genre>Self Help</Genre>
                                    </Book>
                                </Books>";

            // Create an XDocument object from the XML string
            XDocument doc = XDocument.Parse(xmlString);
            XElement rootelmt = doc.Root;

            // Write the title of all books to the console
            foreach (XElement bookElement in rootelmt.Elements("Book"))
            {
                Console.WriteLine("Title: "+ bookElement.Element("Title").Value);
            }
            // Write the title of all books with genre "Genre 1" to the console
            foreach (XElement bookElement in rootelmt.Elements("Book"))
            {
                Console.Write("Title: " + bookElement.Element("Title").Value +"\t");
                Console.WriteLine("Genre: " + bookElement.Element("Genre").Value);
            }
            Console.ReadLine();
        }
    }
}