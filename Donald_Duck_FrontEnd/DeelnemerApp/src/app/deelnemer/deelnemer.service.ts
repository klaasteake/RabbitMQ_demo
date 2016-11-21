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
            .get('http://localhost:56056/api/deelnemer', options)
            .subscribe(response => {
                deelnemers = response.json();
            });
        return deelnemers;
    }
}