import { NgModule, ModuleWithProviders, PipeTransform, Pipe } from '@angular/core';

import { IDeelnemer, FullnamePipe } from './index';

/**
 * Do not specify providers for modules that might be imported by a lazy loaded module.
 */

@NgModule({
  imports: [],
  declarations: [FullnamePipe],
  exports: [FullnamePipe]
})
export class UserModule {
  static forRoot(): ModuleWithProviders {
    return {
      ngModule: UserModule,
      providers: []
    };
  }
}
