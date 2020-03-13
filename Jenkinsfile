pipeline {
    agent { docker 'mcr.microsoft.com/dotnet/core/sdk:3.1' }
    stages {
        stage('build') {
            steps {
                sh 'dotnet build'
            }
        }
    }
}

