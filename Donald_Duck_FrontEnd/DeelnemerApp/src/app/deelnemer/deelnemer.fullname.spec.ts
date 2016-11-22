/* tslint:disable:no-unused-variable */

import { FullnamePipe } from './deelnemer.fullname';
import { IDeelnemer } from './deelnemer.interface';

describe('Pipe: User Fullname', () => {
    let pipe: any;

    beforeEach(() => {
        pipe = new FullnamePipe();
    });

    it('should concat lastName and firstNAme, seperated by a comma', () => {
        let firstName: string = "firstName";
        let lastName: string = "lastName";

        var deelnemer = new DeelnemerContext(firstName, lastName);
        expect(pipe.transform(deelnemer)).toBe('lastName, firstName');
    });
});


class DeelnemerContext implements IDeelnemer {
    readonly id = 0;
    readonly firstName = '';
    readonly lastName = '';
    readonly bSN = 0;
    readonly birthDate = new Date();
    readonly deceasedOnDate = new Date();

    constructor(firstName: string, lastName: string) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}