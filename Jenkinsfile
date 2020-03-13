pipeline {
    agent {
        docker  {
            image 'mcr.microsoft.com/dotnet/core/sdk'
            label '3.1.102-buster'
        }
    }
    stages {
        stage('build') {
            steps {
                sh 'dotnet build'
            }
        }
    }
}

