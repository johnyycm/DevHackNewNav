//
//  ListingViewController.m
//  SupperCoolResaas
//
//  Created by Chenmin Yao on 2017-03-12.
//  Copyright © 2017 Chenmin Yao. All rights reserved.
//

#import "ListingViewController.h"

@interface ListingViewController ()

@end

@implementation ListingViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
//    [[self navigationController ] popViewControllerAnimated:true];
    NSString* imageName;
    switch ([self index]) {
            case 0:
            imageName = @"CreateListing.jpg";
            break;
            case 1:
            imageName = @"CreateLead.jpg";
            break;
            case 2:
            imageName = @"CreateListing.jpg";
            break;
            
        default:
            break;
    }
    [[self imageVIew]setImage:[UIImage imageNamed:imageName]];

}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}
                                        

- (IBAction)BackToTop:(id)sender {
    [self dismissViewControllerAnimated:true completion:nil];
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

@end
