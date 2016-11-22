import { DeelnemerPage } from './app.po';

describe('project-name App', function() {
  let page: DeelnemerPage;

  beforeEach(() => {
    page = new DeelnemerPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
