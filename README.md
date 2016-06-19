# LeetCode Extension

## Description

This is an extension for chrome.

[Download in chrome web store]
(https://chrome.google.com/webstore/detail/leetcode-extension/eomonjnamkjeclchgkdchpabkllmbofp)

Source Code: <https://github.com/binarylu/leetcode-ext>

In source code,  

`leetcode-ext` folder is the source code of chrome extension.

`server` folder is the source code for crawling the problem tags from leetcode.com.

## Usage

There are six major functions:

1. Show your progress, in different difficulities, in different company tags and in different tags.
2. Hide the acceptance and difficulty.
3. Hide the locked problems.
4. Commit your code to your GitHub.
5. After running or submitting code, disable the button for 10 seconds to avoid the error that submitting too frequently.
6. Show the content of locked problems and the problem list of each company tag.
7. Show quick access link for submission and discussion.

For `1`, `2` and `5`, they can be turned on / off in extension option page.

For `3`, there is checkbox in problem list page and tag page.

For `4`, you can login your github account in option page by OAuth. After you login, input the repository name, __*not the URL*__.  
If the repository you type in does not exist, it will be created. Otherwise, just connect to the existing repository.

For `6`, to see the content of locked problem, click the green icon at the right of each locked problem.  
If you are not a subscriber, the linke of each company tag will be changed, there will appear a modal showing the problem list after you click the company tag.  
In problem page, the company tag button will appear even if you are not a subscriber.  

## Contribution

**Quick Access Link** is contributed by [Yiding Liu](https://github.com/petrosliu).

## Acknowledge

This project is just for study, if you can afford, please subscrib to support <https://leetcode.com>.

## Release Notes

v1.1.2 (2016-06-02)  

- Optimize UI.
- Add update notification.

v1.1.1 (2016-06-01)

- Bug fix: The bug that hiding locked problems will hide all the problems has been fixed.

v1.1.0 (2016-05-28)

- Add quick access link for submission and discussion.

v1.0.5  (2016-04-23)

- Add option to commit question.md automitically when entering problem page.

v1.0.0 (2016-04-18)

- show locked problems (click the green icon)
- show progress of each company tag
- show problems in each company tag
- add company tag in problem page

v0.6.0 (2016-04-09)

- Support OAuth, and personal access token is no longer supported. Please open option page to login with OAuth.

v0.5.0 (2016-04-09)

- Support to hide locked problem
- Add chart to show each difficuly's progress

v0.4.7 (2016-04-08)

- Fit the new leetcode UI for difficulty.
- bugfix

v0.4.0 (2016-03-24)

- Add countdown for "run code" button and "submit solution" button, so that you will never run/submit too frequently.
- Support to set default comment.
- Add popup, click LeetCode Extension icon, you can go to leetcode.com directly.

v0.3.5 (2016-03-22)

- Support to add an existing repository

v0.3.0 (2016-03-22)

- Hide acceptance and difficulty.
- Add option to commit only accepted codes.