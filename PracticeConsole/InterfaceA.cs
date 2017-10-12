using PracticeConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    interface InterfaceA
    {
        // Static Keyword can not use in Interfaces
        // Fields can not initialize in Interfaces
        // Accesss Modifier " Public / Protected / Private " can not use in Interfaces
        // Default Properties can only use in Interface ( e.g PropertyName { get; set; } ) 


        #region Properties

        string Public_Str_A { get; set; }
        
        #endregion


        #region Constructor

        void A();


        #endregion

        #region Methods





        #endregion



        #region Override Methods




        #endregion



    }
    
}

    interface InterfaceB
    {

    }
    interface InterfaceC
    {

    }
    interface InterfaceD : InterfaceA , InterfaceB , InterfaceC
    {

    }
