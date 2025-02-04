import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ResultModel } from '../models/result.model';
import { api } from '../constants';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  token: string = "";

  constructor
    (
      private _http: HttpClient
    ) { }

    post<T>(apiUrl:string, body:any, callBack: (res:ResultModel<T>)=> void, errCallBack?: (err: HttpErrorResponse)=> void){
      this._http.post<ResultModel<T>>(`${api}/${apiUrl}`,body, {
        headers: {
          "Authorization": "Bearer " + this.token 
        }
      })
      .subscribe({
        next: (res=> {
          callBack(res);      
        }),
        error: ((err:HttpErrorResponse)=> {
          // this.error.errorHandler(err);
  
          if(errCallBack !== undefined){                    
            errCallBack(err);
          }        
        })
      })
    }

}
