import { IUser } from '../user/user.interface';

export class UserContext implements IUser {
    readonly firstName = '';
    readonly surname = '';
    readonly emailAddress = '';
    fullName = function(){
        return `${this.surname}, ${this.firstName}`;
    }

    constructor(user : IUser) {
        this.firstName = user.firstName;
        this.surname = user.surname;
        this.emailAddress = user.emailAddress;
    }

    static CreateDummy(firstName : string, surname: string, emailAddress: string) : UserContext
    {
        var dummy = new DummyUserContext(firstName, surname, emailAddress);
        return new UserContext(dummy);
    }
}

export class DummyUserContext implements IUser{
        readonly firstName : string;
        readonly surname : string;
        readonly emailAddress : string;

        constructor(firstName : string, surname : string, emailAddress : string){
            this.firstName = firstName,
            this.surname = surname,
            this.emailAddress = emailAddress
        }
    }