import { NgModule, ModuleWithProviders, PipeTransform, Pipe } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';

import { IDeelnemer, FullnamePipe } from './index';

/**
 * Do not specify providers for modules that might be imported by a lazy loaded module.
 */

@NgModule({
  imports: [],
  declarations: [FullnamePipe],
  exports: [FullnamePipe]
})
export class DeelnemerModule {
  static forRoot(): ModuleWithProviders {
    return {
      ngModule: DeelnemerModule,
      providers: []
    };
  }
}
