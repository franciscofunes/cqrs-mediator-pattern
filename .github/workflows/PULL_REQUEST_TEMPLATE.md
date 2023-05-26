name: Pull Request Description

on:
  pull_request:
    types:
      - opened

jobs:
  automate-description:
    runs-on: ubuntu-latest

    steps:
      - name: Check out repository
        uses: actions/checkout@v2

      - name: Set pull request description
        run: |
          echo "## Description" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "Please provide a brief description of the changes introduced in this pull request." >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "## Checklist" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "- [ ] I have tested these changes locally." >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "- [ ] I have reviewed the code and ensured it follows the project's guidelines." >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "- [ ] I have updated the documentation, if necessary." >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "## Related Issues" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "Closes #${{ github.event.pull_request.number }}" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "## Jira Ticket" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "Jira Ticket: [JIRA-1234](https://your-jira-instance.com/browse/JIRA-1234)" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "## Test Instructions" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "Please follow these steps to test the changes:" >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "1. Step 1..." >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "2. Step 2..." >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md
          echo "3. Step 3..." >> $GITHUB_WORKSPACE/.github/PULL_REQUEST_TEMPLATE.md

      - name: Commit and push changes
        run: |
          git config --global user.name "Your Name"
          git config --global user.email "your-email@example.com"
          git add .github/PULL_REQUEST_TEMPLATE.md
          git commit -m "Update pull request description template"
          git push
