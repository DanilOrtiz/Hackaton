import { Injectable } from "@angular/core";
import {Http} from '@angular/http';
import { Observable } from "rxjs/Observable";
import { Suceso, SucesoValoracion, Categoria } from "../models/app.models";
import 'rxjs/add/operator/map';
import 'rxjs/Rx';

@Injectable()
export class AppService {
  Url: string = "http://10.150.88.63:81/api/";
  constructor(private http: Http) {
      
  }

  ObtenerPermisos(): Observable<Suceso> {
    let uri = `/https://www.dropbox.com/obtenerSuceso`;
    return this.http.get(uri).map(data => data.json() as Suceso);
  }


  ObtenerSucesos() : Observable<Suceso[]>
  {
    let uri = this.Url + "ObtenerSucesos";
    return this.http.get(uri).map(data => data.json() as Suceso[]);
  }

  ObtenerTopSuceso() : Observable<Suceso[]>
  {
    let uri = this.Url + "ObtenerTopDeSuceso/5";
    return this.http.get(uri).map(data => data.json() as Suceso[]);
  }

  ObtenerTopSucesosMenorDeID(sucesoId: number) : Observable<Suceso[]>
  {
    let uri = this.Url + "ObtenerTopDeSucesosMenorDeId/5/" + sucesoId;
    return this.http.get(uri).map(data => data.json() as Suceso[]);    
  }

  InsertarValoracion(valoracionId: number,sucesoId: number,usuarioId: number): Observable<SucesoValoracion>
  {
    let uri = this.Url + "InsertarValoracion/" + sucesoId + "/"+ valoracionId+"/"+usuarioId;
    return this.http.get(uri).map(data => data.json() as SucesoValoracion);  
  }

  ObtenerCategorias() : Observable<Categoria[]>
  {
    let uri = this.Url + "ObtenerCategorias";
    return this.http.get(uri).map(data => data.json() as Categoria[]);
  }
  
}