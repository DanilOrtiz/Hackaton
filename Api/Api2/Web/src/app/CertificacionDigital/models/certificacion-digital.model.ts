import { strictEqual } from "assert";

export class UEN
{

constructor(
public id: number = 0,
public descripcion: string = "",
public fechaAgrega: Date = new Date,
public activo: boolean = true,
public usuarioAgregaId: number =0,

)
{}
}



export class Sprint
{

    constructor(
    public id: number =0,
    public descripcion: string = "",
    public fechaFin: Date = new Date,
    public fechaInicio: Date = new Date,
    public fechaModifica: Date = new Date,
    public usuarioModifica: number =0,
    public fechaAgrega: Date = new Date,
    public usuarioAgregaId: number = 0,
    public activo: boolean = true,     
    )
    {}

}

export class Departamento
{

    constructor(
        public id: number = 0,
        public descripcion: string="",
        public uenId: number=0,
        public uen: UEN = new UEN(),
        public fechaAgrega: Date = new Date,
        public usuarioAgregaId: number = 0,
        public activo: boolean = true,  
        
    )
    {}
}


export class Usuario
{
   constructor(
        public id: number =0,
        public nombre: string="",
        public apellido: string="",
        public nombreCompleto: string="",
        public clave : string ="",
        public codigoColaborador: number=0,
        public correoElectronico: string="",
        public perfilId: number = 0,
        public fechaAgrega: Date = new Date,
        public usuarioAgregaId: number = 0,
        public activo: boolean = true,
        public telefono: string = "",
    )
    {

    }
}


export class Solicitante
{

    constructor(
        public id: number=0,
        public descripcion: string="",
        public correo: string="",
        public telefono: string="",
        public departamentoId: number=0,
        public departamento: Departamento = new Departamento(),
        public usuarioId: number=0,
        public usuario: Usuario = new Usuario(),
        public fechaAgrega: Date = new Date,
        public usuarioAgregaId: number = 0,
        public activo: boolean = true, 

    )
    {

    }

}