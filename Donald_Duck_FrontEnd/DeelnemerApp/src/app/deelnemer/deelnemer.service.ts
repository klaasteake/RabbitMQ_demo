import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';

import { IDeelnemer } from './deelnemer.interface';

@Injectable()
export class DeelnemerService {

    constructor(private http: Http) { }

    getDeelnemers(): IDeelnemer[] {
        let deelnemers: IDeelnemer[] = [];
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        this.http
            .get('http://localhost:36600/api/deelnemer', options)
            .subscribe(response => {
                deelnemers = response.json();
            });
        return deelnemers;
    }

    addDeelnemer(context : IDeelnemer): any {
        let result: any;
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        this.http
            .post('http://localhost:36600/api/deelnemer', context, options)
            .subscribe(response => {
                 result = response.json();
            });
        return result;
    }

    updateDeelnemer(context : IDeelnemer): any {
        let result: any;
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        this.http
            .put('http://localhost:36600/api/deelnemer', context, options)
            .subscribe(response => {
                 result = response.json();
            });
        return result;
    }
}