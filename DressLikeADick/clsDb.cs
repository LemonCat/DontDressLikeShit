using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DressLikeADick
{
    class clsDb
    {

        public clsDb()
        {

            //Fuck databases. Go full XML. 


            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ddls_cat.xml") && File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ddls_outfit.xml") && File.Exists(AppDomain.CurrentDomain.BaseDirectory + "ddls_outfits.xml"))
	        {
		        //we good

                //Load everything



            }else
	        {
                //well fuck
	        }
            
        }
        

        //Destructeur
        ~clsDb()
        {
            try
            {
                //do nothing
            }
            catch (Exception)
            {
                
            }
            
        }

    }
}
