# scammy-bbp
Bug bounty programs that are "scammy" or unethical can sometimes involve promising rewards to researchers for identifying security flaws, but either delay payments, don't pay at all, or misuse the disclosed vulnerabilities. 


Signs of a Potentially Scammy Bug Bounty Program:

- Unclear Terms and Conditions: Programs that don't clearly specify what vulnerabilities qualify for rewards or the amount of the reward.
- No Transparent Payment Structure: Lack of details about payment timelines, payout methods, or cases where people report not getting paid.
- Little to No Community Feedback: Lack of reputation or negative reviews from the infosec community.

`Hits: # of reports of being scammy`

| Program Name              | Issues Reported                                        | Platform | Source     | Hits
|---------------------------|-------------------------------------------------------|------------|----------------------| ------
| **[H&M](https://www.hm.com/security.txt)** | No rewards<sup>1</sup> |Self hosted|  Trusted hacker | 2
| **[Celonis](https://www.celonis.com/pdf/vulnerability-disclosure-program/)** | Ignored reports<sup>2</sup> | Self hosted |Trusted hacker        | 1
| **[TataPlay](https://www.tataplay.com/bug-bounty-hunter)** | Automated Response, then no response | Self hosted| Trusted Hacker | 1
| **[Synack](https://synack.responsibledisclosure.com/hc/en-us)** | Reward Gatekeepers<sup>10</sup>|Self hosted | Trusted Hacker | 1
| **[Zeiss](https://www.zeiss.com/disclosure-policy.pdf)**| Ignored reports<sup>2</sup> | Self hosted |Trusted hacker| 1
| **[Alefed](https://vdp.alefeducation.com/p/Vulnerability-Disclosure-Policy-and-Submission-Form)**| No impact but fixed<sup>3</sup> |Self hosted+YesWeHack|Trusted hacker | 1
| **[Cex.io](https://blog.cex.io/news/cex-io-bug-bounty-program-and-policy-22948)**| Failed to pay<sup>4</sup> | Self hosted | Trusted hacker | 1 
| **[Roche](https://hackerone.com/roche?type=team)** | Patch & Pass<sup>5</sup><br> Duplicate Disguise<sup>7</sup><br>Duplicate Mirage<sup>8</sup><br>Smokescreen Smackdown<sup>12</sup>|Self hosted | Trusted Hacker | 2
| **[Zopa](https://zopa.com/.well-known/security.txt)** | Scope Surprise!<sup>9</sup> |Self hosted | Trusted hacker | 1
| **[Atos](https://hackerone.com/atos?type=team)**| Bounty Roulette<sup>11</sup>|Self hosted | Trusted hacker | 1
| **[LuminPDF](https://www.luminpdf.com/bug-bounty-program)** | No impact but fixed<sup>3</sup>|Self hosted | Trusted hacker | 1
| **[ItsLearning](https://itslearning.com/privacy-commitment/responsible-disclosure)** | Fixed and Ignored Reports<sup>2</sup> | Self hosted | Trusted Hacker | 1
| **[Resortdata](https://www.resortdata.com/about/responsible-disclosure/)** | Fixed and Ignored Reports<sup>2</sup> | Self hosted | Trusted Hacker | 1
| **[Scalr](https://www.scalr.com/system-description)** | No impact but fixed<sup>3</sup> | Self hosted | Trusted Hacker | 1
| **[Standard Bank](http://www.standardbank.co.za/)** | Fixed and Ignored Reports<sup>2</sup> | Self hosted | Trusted Hacker | 1
| **[Zynga](https://www.zynga.com/security/rdp)** | Fixed and Ignored Reports<sup>2</sup> | Self hosted | Trusted Hacker | 1
| **[Microsoft](https://www.microsoft.com/en-us/msrc/bounty)** | Fixed and Ignored Reports<sup>2</sup> <br>  | Self hosted | Trusted Hacker | 2
| **[Cimpress](https://cimpress.com/privacy-security/)** | Bounty Roulette<sup>11</sup> | Self hosted | Trusted Hacker | 2
| **[Swiggy](https://www.swiggy.com/bug-bounty)** | No rewards<sup>1</sup> | Self hosted | Trusted Hacker | 1


## Hackerone

The input for this section are public reports and writeups made by researchers. 

| Program Name     | Report       | Problems | Discussion
|----------------|---------------|------------|---------------
| **[Hackerone]()**|[2180521](https://hackerone.com/reports/2180521)|CVSS magic| https://github.com/pdelteil/scammy-bbp/discussions/9
|**[Zendesk]()**| [URL](https://gist.github.com/hackermondev/68ec8ed145fcee49d2f5e2b9d2cf2e52)|Sacred Out of Scope| https://github.com/pdelteil/scammy-bbp/discussions/10

## BugCrowd

| Program Name              | Issues Reported                                        | Platform | Source     | Hits
|---------------------------|-------------------------------------------------------|------------|----------------------| ------
| **WesternUnion** | Fixed and Ignored Reports<sup>2</sup> <br> Dupe-n-Dump<sup>13</sup>  | Self hosted | Trusted Hacker | 2


## Details

- <sup>1</sup>**No rewards:** They promise rewards for reports in their program, but fail to pay them. Sometimes they just say they stopped paying rewards or they can't do it anymore.
- <sup>2</sup>**Ignored reports:** They never replied back to researcher. Never > 2 months and counting.
- <sup>3</sup>**No impact but fixed:** Bug triaged as CVSS 0, no impact or similar but fixed anyways.  
- <sup>4</sup>**Failed to pay:** Agreed to pay a bounty but never accomplished it. Often ignoring follow-up emails.
- <sup>5</sup>**Patch & Pass:** They fix reported bugs but mark them as Out of scope.
- <sup>6</sup>**P1 or You're Out:** They won't invite you to their private program unless you report a P1/High bug.
- <sup>7</sup>**Duplicate Disguise:** They mark reports as duplicated when they are very unlikely to be reported before.
- <sup>8</sup>**Duplicate Mirage:** They mark all (future) reports as dups without having the full list of domains. 
- <sup>9</sup>**Scope Surprise!:** They define their `in scope` and `out scope` after you send the report, they don't write it down in their program brief.
- <sup>10</sup>**Reward Gatekeepers:** They will pay a reward only if you have an account in their site (which might very difficult to get).
- <sup>11</sup>**Bounty Roulette:** Not clear if they pay bounties or not. Often times the include deciving information: calling their page or site 'bug bounty program', having an email address containing bug bounty, etc. 
- <sup>12</sup>**Smokescreen Smackdown:** When a company tries to damage the reputation of a reporter.
- <sup>13</sup>**Dupe-n-Dump :** They mark all reports of the same type/class as dups.
