//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuezzyEn
{
    using System;
    using System.Collections.Generic;
    
    public partial class questions
    {
        public int idQuestion { get; set; }
        public int idChapter { get; set; }
        public int idLesson { get; set; }
        public string title { get; set; }
        public string var1 { get; set; }
        public string var2 { get; set; }
        public string var3 { get; set; }
        public string var4 { get; set; }
        public string answer { get; set; }
    
        public virtual Chapter Chapter { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
