pipeline {
    agent { docker 'mcr.microsoft.com/dotnet/core/sdk:3.1' }
    environment {
       HOME = '/tmp'
    } 
    stages {
        stage('build') {
            steps {
                sh 'dotnet build'
            }
        }
    }
}

