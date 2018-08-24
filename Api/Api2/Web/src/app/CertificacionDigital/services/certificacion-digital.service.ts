import { Injectable } from '@angular/core';
import { Http,Headers } from "@angular/http";
import { Observable } from 'rxjs/Observable';
import { HttpAuthService } from '../../helpers/http/http-auth.service';
import { UEN, Sprint, Departamento, Usuario, Solicitante } from '../models/certificacion-digital.model';
import { environment } from '../../../environments/environment'
import 'rxjs/add/operator/map';
import { List } from 'linqts';

@Injectable()
export class CertificacionDigitalService{

    constructor(private http: Http)
    {}



obtenerUENS(): Observable<UEN[]>{

    let headers = new Headers({
        'Content-Type': 'application/json'

    });

    const uri = environment.certificacionApi + "certificacion/uen/UENSActivos";
    return this.http.get(uri, {headers}).map(x => x.json() as UEN[]);
}

agregarUEN(uen: UEN){
    const uri = environment.certificacionApi + "certificacion/uen/GuardarUENS";
    return this.http.post(uri,uen);
}

editarUEN(uen: UEN){
    const uri = environment.certificacionApi + "certificacion/uen/EditarUENS";
    return this.http.post(uri,uen);
}

obtenerSprint(): Observable<Sprint[]>{
    const uri = environment.certificacionApi + "certificacion/sprint/ObtenerSprints";
    return this.http.get(uri).map(x => x.json() as Sprint[]);
}

agregarSprint(sprint: Sprint){
    const uri = environment.certificacionApi + "certificacion/sprint/AgregarSprint";
    return this.http.post(uri,sprint);
}

editarSprint(sprintEdit: Sprint){
    const uri = environment.certificacionApi + "certificacion/sprint/EditarSprint";
    return this.http.post(uri,sprintEdit);

}

obtenerDepartamentos(): Observable<Departamento[]>{
    const uri = environment.certificacionApi + "certificacion/departamento/ObtenerDepartamentos";
    return this.http.get(uri).map(x=> x.json() as Departamento[]);
}

agregarDepartamento(departamento: Departamento)
{
    const uri = environment.certificacionApi + "certificacion/departamento/AgregarDepartamento";
    return this.http.post(uri,departamento);

}

editarDepartamento(departamento: Departamento)
{
    const uri = environment.certificacionApi + "certificacion/departamento/EditarDepartamento";
    return this.http.post(uri,departamento);
}


obtenerUsuarios(): Observable<Array<Usuario>>{
    const uri = environment.certificacionApi + "certificacion/usuario/ObtenerUsuarios";
    return this.http.get(uri).map(x=> x.json() as Array<Usuario>);

}

agregarUsuario(usuarioNuevo: Usuario)
{
    const uri = environment.certificacionApi + "certificacion/usuario/AgregarUsuario";
    return this.http.post(uri,usuarioNuevo);
}

editarUusario(usuarioEdit: Usuario)
{
    const uri= environment.certificacionApi +"certificacion/usuario/EditarUsuario";
    return this.http.post(uri,usuarioEdit);
}

obtenerSolicitantes(): Observable<Solicitante[]>{
    const uri = environment.certificacionApi +"certificacion/solicitante/ObtenerSolicitantes";
    return this.http.get(uri).map(x => x.json() as Solicitante[]);
}

agregarSolicitante(solicitanteNuevo: Solicitante)
{
    const uri = environment.certificacionApi+"certificacion/solicitante/AgregarSolicitante";
    return this.http.post(uri,solicitanteNuevo);
}


editarSolicitante(solicitanteEdit:Solicitante)
{
    const uri = environment.certificacionApi+"certificacion/solicitante/EditarSolicitante";
    return this.http.post(uri,solicitanteEdit);

}

}