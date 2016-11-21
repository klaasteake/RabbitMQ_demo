import { FullnamePipe } from './deelnemer.fullname';
import { IDeelnemer } from './deelnemer.interface';

export function main() {
    describe('Pipe: User Fullname', () => {
        let pipe: any;

        beforeEach(() => {
            pipe = new FullnamePipe();
        });

        it('should concat surname and firstname, seperated by a comma', () => {
            let firstName: string = "firstName";
            let surname: string = "surname";
            let emailAddress: string = "a@a.aa"

            var deelnemer = new DeelnemerContext(firstName, surname, emailAddress);
            expect(pipe.transform(deelnemer)).toBe('surname, firstName');
        });
    });
}

class DeelnemerContext implements IDeelnemer {
    readonly firstName = '';
    readonly surname = '';
    readonly emailAddress = '';

    constructor(firstName: string, surname: string, emailAddress: string) {
        this.firstName = firstName,
            this.surname = surname,
            this.emailAddress = emailAddress
    }
}