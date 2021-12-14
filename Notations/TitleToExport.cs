using System;
using System.ComponentModel.DataAnnotations;

namespace Calculadora.Notations
{
	 public class TitleToExport : ValidationAttribute
    {
        public readonly string Title;

        public readonly Type FormatType;

        public TitleToExport() { }

        public TitleToExport(string title) => Title = title;
	
	
        //eliminar codigo comentado code smell
        // public TitleToExport(string title, Type formatType)
        // {
        //     Title = title;
        //     FormatType = formatType;
        // }
    }
}
