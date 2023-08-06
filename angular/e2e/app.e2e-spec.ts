import { QuanLyBanHangTemplatePage } from './app.po';

describe('QuanLyBanHang App', function() {
  let page: QuanLyBanHangTemplatePage;

  beforeEach(() => {
    page = new QuanLyBanHangTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
