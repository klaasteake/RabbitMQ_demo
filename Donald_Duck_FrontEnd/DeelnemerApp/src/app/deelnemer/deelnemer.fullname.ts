import { PipeTransform, Pipe } from '@angular/core';
import { IDeelnemer } from './deelnemer.interface';


@Pipe({
    name: 'fullname'
})
export class FullnamePipe implements PipeTransform {
    transform(deelnemer: IDeelnemer, ...args: any[]): any {
        return `${deelnemer.surname}, ${deelnemer.firstName}`;
    }
}