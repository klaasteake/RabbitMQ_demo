import { Component } from '@angular/core';
import { IDeelnemer, FullnamePipe, DeelnemerService } from './deelnemer';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app works!';

  deelnemers : IDeelnemer[];

  constructor(private deelnemerService: DeelnemerService) {
    this.deelnemers = deelnemerService.getDeelnemers();
  }
}
