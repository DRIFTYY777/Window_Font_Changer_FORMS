using System.Diagnostics;
using System.Drawing.Text;
using System.Text;

namespace Window_Font_Changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // button for load all contacts
        {
            using (InstalledFontCollection col = new InstalledFontCollection()) //using all installed fonts. also include using System.Drawing.Text;
            {
                foreach (FontFamily fa in col.Families)         // for loop for displaying all fontsin list view
                {
                    Fonts_List.Items.Add(fa.Name);              //getting all fonts 
                }
                Fonts_List.SelectionMode = SelectionMode.One;   //this is for only select one
                Fonts_List.SetSelected(1, true);                //this is for only select one
                Fonts_List.SetSelected(2, true);                //this is for only select one
            }
        }

        String path()                                           // this function for loacte path of original file
        {
            var path = "original file.bat";                     // path of original file (for coping nd pasting)
            var fullPath = Path.GetFullPath(path);              //here full path  (for coping nd pasting and checking file exists or not)
            var path2 = "changer.reg";                          // defining path of copied file from original file
            var fullPath2 = Path.GetFullPath(path2);
            if (File.Exists(fullPath2))                         //this for checking dublicate exists if exists delete it! and create new copy of original one
            {
                File.Delete(path2);                             //deleting copied file cause we dont use it again
                File.Copy(path, path2);                         //or coping/pasting file from (original to dublicate)
            }
            else                                                //this else for checking original file exists or not
            {
                if (File.Exists(fullPath))                      //this for checking original file exists or not 
                {
                    File.Copy(path, path2);                     //if exists make a new copy of original file
                }
                else                                            //else for checking original exists or not 
                {
                    MessageBox.Show("orignial file missing!", "Reinstall It!");//if not exists this message will pop up. you can read message in message box
                }
            }
            return fullPath2;                                   //returning the fullpath/path of (new created file) Note: rememberer dublicate file used once mot again
        }
        private void Done_Click(object sender, EventArgs e)     //button for executing replacing function and also (run the registery file)
        {
            String selected = Fonts_List.SelectedItem.ToString();//getting selected Font from user
            replacing(selected);                                //calling replacing function and giving a font name selected by user 
        }

        private void runner()                                   //runner function for run reg.file (which is important for font changing)
        {
            var filepath = path();                              //calling path function for locating file
            Process p = new Process();                          //creating new process 
            ProcessStartInfo pi = new ProcessStartInfo();       //checkin ProcessStartInfo or i dont know
            pi.UseShellExecute = true; 
            pi.FileName = filepath;                             //defining file location 
            p.StartInfo = pi;                                   //geting file info
            try                                                 //try if file exeist run it or not throw error or if user mannuly close the file it also throw an error
            {
                p.Start();                                      //simply file.run
            }
            catch (Exception Ex)                                //capturing unexpected error like file crash or file not found or user mannuly close the file it also throw an error
            {
                MessageBox.Show(Ex.Message);                    //displaying error only
            }
        }

        private void replacing(String name)                     //this function replacing "Consolas" text with new font given or selected by user
        {
            var filepath = path();                              //calling path function for locating file to make some changes in it!
            try                                                 //try for try if not work go to catch (Exception Ex) function
            {    
                string str = File.ReadAllText(filepath);        //reading all text in dublicate file 
                str = str.Replace("Consolas", name);            //replacing "Consolas font" with user selected font
                File.WriteAllText(filepath, str);               //replacing "Consolas font" with user selected font
                runner();                                       //calling runner function for run main file (which is important for font changing) or execute/run reg file!
            }
            catch (Exception Ex)                                //Exception for catching unexpected error for printing on display
            {
                MessageBox.Show(Ex.ToString(), "if you are seeing this means you close this or unexpexted error");//just displaying a unknown error 
            }
        }
    }
}