import { Injectable } from "@angular/core";
import {Http} from '@angular/http';
import { Observable } from "rxjs/Observable";
import { Suceso } from "../models/app.models";
import 'rxjs/add/operator/map';
import 'rxjs/Rx';

@Injectable()
export class AppService {
  constructor(private http: Http) {
      
  }

  ObtenerPermisos(): Observable<Suceso> {
    let uri = `/https://www.dropbox.com/obtenerSuceso`;
    return this.http.get(uri).map(data => data.json() as Suceso);
  }
  
}