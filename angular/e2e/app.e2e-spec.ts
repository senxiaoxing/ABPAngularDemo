import { ABPAngularTemplatePage } from './app.po';

describe('ABPAngular App', function() {
  let page: ABPAngularTemplatePage;

  beforeEach(() => {
    page = new ABPAngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
