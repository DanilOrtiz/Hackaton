import { Angular4BasePage } from './app.po';

describe('angular4-base App', () => {
  let page: Angular4BasePage;

  beforeEach(() => {
    page = new Angular4BasePage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
