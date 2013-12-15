using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADesignerCore.Entities
{
    public class LanguagePacks
    {
        LanguagePacksElement element = new LanguagePacksElement("LanguagePacks");
        LanguagePack languagePack;
        public LanguagePack LanguagePack
        {
            get
            {
                return languagePack;
            }
            set
            {
                languagePack = value;
                Element.RemoveNodes();
                Element.Add(languagePack.Element);
            }
        }

        public LanguagePacksElement Element { get { return element; } }
    }
}
