//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Instap.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Comentario = new HashSet<Comentario>();
            this.Publicacion = new HashSet<Publicacion>();
        }
    
        public int Id { get; set; }
        public string email { get; set; }
        public string nombres_comp { get; set; }
        public string nombre_usuario { get; set; }
        public string password { get; set; }
        public string sexo { get; set; }
        public string biografia { get; set; }
        public string telefono { get; set; }
        public Nullable<int> tipo_user { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentario> Comentario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Publicacion> Publicacion { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}
