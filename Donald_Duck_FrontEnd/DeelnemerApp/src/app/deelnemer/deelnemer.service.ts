import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';

import { IDeelnemer } from './deelnemer.interface';

@Injectable()
export class DeelnemerService {

    constructor(private http: Http) { }

    getDeelnemers(callback: GetResponseAction<IDeelnemer[]>) {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        let deelnemers: IDeelnemer[];
        this.http
            .get('http://localhost:36600/api/deelnemer', options)
            .subscribe(response => {
                if(response.ok){
                    deelnemers = response.json();
                }
                if(typeof callback === "function"){
                    callback(deelnemers, response.ok);
                }
            });
    }

    addDeelnemer(context : IDeelnemer, callback : ResponseAction) {
        let ok: boolean;
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        this.http
            .post('http://localhost:36600/api/deelnemer', context, options)
            .subscribe(response => {
                if(typeof callback === "function"){
                    callback(response.ok);
                }
            });
    }

    updateDeelnemer(context : IDeelnemer, callback: ResponseAction) {
        let result: any;
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        this.http
            .put('http://localhost:36600/api/deelnemer', context, options)
            .subscribe(response => {
                if(typeof callback === "function"){
                    callback(response.ok);
                }
            });
    }
}

interface GetResponseAction<T>
{
    (item: T, success: boolean): void;
}

interface ResponseAction
{
    (success: boolean): void;
}