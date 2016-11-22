import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';

import { IDeelnemer } from './deelnemer.interface';

@Injectable()
export class DeelnemerService {

    constructor(private http: Http) { }

    getDeelnemers(deelnemers : IDeelnemer[]) {
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        let body: IDeelnemer[];
        this.http
            .get('http://localhost:36600/api/deelnemer', options)
            .subscribe(response => {
                body = response.json();
                body.forEach(element => {
                    deelnemers.push(element);
                });
            });
    }

    addDeelnemer(context : IDeelnemer): any {
        let ok: boolean;
        let headers = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        this.http
            .post('http://localhost:36600/api/deelnemer', context, options)
            .subscribe(response => {
                 ok = response.ok
            });
        return ok ? "Het voerzoek tot het toevoegen van deelnemer " + context.lastName + ", " + context.firstName : "";
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