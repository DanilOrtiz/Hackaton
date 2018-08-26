export class Ciudad {
    constructor(
        public nombre: string = "",
        public latitud: number = 0,
        public longitud: number = 0)
    {}
}

export class Usuario {
    constructor(
       public nombre: string = "",
       public apellido: string = "",
       public usuarioNombre: string = "",
       public clave: string = "",
       public ciudadId: number = 0,
       public ciudad: Ciudad = new Ciudad(),
       public perfilId: number=0,
       public imagenUrl:string="",
       public correo:string="",
       public perfil:Perfil=new Perfil,
       public suceso:Suceso=new Suceso,
       public sucesoComentario:SucesoComentario=new SucesoComentario,
       public sucesoValoracion:SucesoValoracion=new SucesoValoracion,
       public empresa:Empresa=new Empresa

    ){}
}
export class Empresa {
  constructor(
      public nombre:string="",
      public imagenEmpresa:string="",
      public bannerEmpresa:string="",
      public telefonoEmpresa:string="",
      public whatsappEmpresa:string="",
      public correoEmpresa:string="",
      public sitioWeb:string="",
      public direccionEmpresa:string="",
      public latitud:string="",
      public longitud:string="",
      public nombreContacto:string="",
      public correoContacto:string="",
      public usuarioId:string="",
      public esGubernamental:boolean=true,
      public sucesoValoracion:SucesoValoracion=new SucesoValoracion,
  )
  {}
}
export class Suceso {
    constructor(
      public id: number = 0,
      public usuarioId: number=0,
      public descripcion: string="",
      public latitud: string="",
      public logitud: string="",
      public SucesoCaracteristicaId:number=0,
      public esAnonimo:boolean=false,
      public ciudadId:number=0,
      public estadoId:number=0,
      public usuario:Usuario = new Usuario,
      public ciudad:Ciudad = new Ciudad,
      public sucesoCategoria: SucesoCategoria[] = null,
      public sucesoComentarios: SucesoComentario[] = null,
      public sucesoMultimedia: SucesoMultimedia[] = null,
      public sucesoValoracion: SucesoValoracion[] = null,
      public estado:Estado = new Estado,
      public fechaAgrega: Date = new Date,
      public cantidadComentarios: number = 0,
      public mostrarComentarios: boolean = false,
    )
    {}
}
export class Estado {
  constructor(
      public descripcion: string = "",
      public suceso:Suceso = new Suceso,
      )
  {}
}

export enum TipoEstados {
    Nueva = 1,
    Eliminada = 2
}

export class Perfil {
    constructor(
        public nombre: string = "")
    {}
}

export class SucesoCategoria {
    constructor(
        public nombre: string = ""
        )
    {}
}
export class SucesoComentario {
  constructor(

      public sucesoId :number=0,
      public comentario: string = "",
      public usuarioId:number=0,
      public suceso: Suceso=new Suceso,
      public usuario: Usuario=new Usuario,
      public fechaAgrega: Date = new Date,
      )
      {}
    }
    export class SucesoMultimedia {
      constructor(

          public ruta :string ="",
          public nombre: string = "",
          public SucesoMultimediaTipoId:number=0,
          public SucesoId: number=0,
          public suceso: Suceso=new Suceso,
          public SucesoMultimediaTipo: SucesoMultimedia= new SucesoMultimedia
          )
          {}
        }
export class SucesoMultimediaTipo {
          constructor(
              public nombre: string = "",
              public sucesoMultimedia: SucesoMultimedia[] = null
              )
              {}
 }
 export class SucesoValoracion {
  constructor(
      public sucesoId: number=0,
      public usuarioId: number=0,
      public suceso:Suceso=new Suceso,
      public usuario:Usuario = new Usuario,
      public sucesoValoracionTipo: SucesoValoracion= new SucesoValoracion
      )
      {}
}
export class SucesoValoracionTipo {
  constructor(
      public nombre: string="",
      public valoracion: number=0,
      public sucesoValoracion: SucesoValoracion[] = null
      )
      {}
}

export class Categoria {
    constructor(
        public nombre: string = "",
        public ImagenUrl: string = "",
        )
    {}
}